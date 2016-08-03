using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Enums;
using WebApplication1.Models;
//windowsun color kütüphanesini kullanmak için


namespace WebApplication1.Controllers
{
    public class ExportController : Controller
    {
        private readonly IServiceTrainee _serviceStudent;
        private readonly IServiceJobInterview _serviceInterview;

        public ExportController(IServiceTrainee serviceStudent, IServiceJobInterview serviceInterview)
        {
            _serviceInterview = serviceInterview;
            _serviceStudent = serviceStudent;
        }

        public ActionResult Excel()
        {
            //Veri tabanında mevcut silinmeyen tüm öğrencilerin çekilmesi
            var studentsGetAll = _serviceStudent.GetAll()
                .Where(s => s.IsDeleted == false)
                .ToList();

            //StudentInterviewModel data binding
            var students = studentsGetAll.Select(
                s => new StudentInterviewModel
            {
                IdentityNumber = s.TcIdentity,
                FullName = s.FirstName + " " + s.LastName,
                BranchName = s.KursiyerEğitims.OrderByDescending(x=>x.EducationEndDate).FirstOrDefault().IskurClassroom.Classroom.Branch.Name,
                EducationName = s.KursiyerEğitims.OrderByDescending(x=>x.EducationEndDate).FirstOrDefault().Education.Name,
                StudentWorkState = "",//StudentWorkState = s.StudentWorkStateDetails.Count > 0 ? s.StudentWorkStateDetails.OrderByDescending(y => y.StudentId).First().StudentWorkState.Name : "",  //y => y.studentId, modifiedDate idi düzenlecek
                //Öğrenciyi rezerve eden firma id'si ile firmalar tablosundan ismini çekme işlemi
                ReserverdCompanyName = s.ReservedFirm != null ? s.ReservedFirm.Name : "",

                //Öğrenciye ait son 3 görüşmenin tarihe göre sıralanarak çekilmesi
                Interviews = _serviceInterview.GetAll()
                .Where(x => x.IsDeleted == false && x.TraineeId == s.Id)
                .Select(
                x => new JobInterview
                {
                    Firm = x.Firm,
                    Date = x.Date,
                    Description = x.Description,
                    //db de valueları tutulan enumların name değerlerinin gösterilmesi
                    ModelType = x.ModelType
                })
                .OrderByDescending(x => x.Date)
                .Take(3)
                .ToList()
            });

            // Excel dosyasının oluşturulacağı isim ve dosya yolu
            var fileName = "Ogrenci-Gorusme-Takip-Listesi-" + DateTime.Now.ToString("yyyy-MM-dd--hh-mm-ss") + ".xlsx";
            var outputDir = AppDomain.CurrentDomain.BaseDirectory + "/App_Data/Export/";


            // FileInfo kullanaran dosya oluşturma
            var file = new FileInfo(outputDir + fileName);

            // Excel dosyasının oluşturulma işlemi
            using (var package = new ExcelPackage(file))
            {
                // adı "Görüşme Takibi ve o gününtarihi" olan yeni bir boş Excel sekmesi oluşturuyoru<
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Görüşme Takibi");

           
                //İlk satır başlığın değeri ve hangi hücrede olacağı.
                //İkinci satır bu başlığın kaç kolonluk yer kaplıycağını belırtır.
                //ikinci satırda başlangıç ve bitiş değerleri varilerek kolonları birleştirir.
              
                worksheet.Cells[1, 1].Value = "FİRMA - ÖĞRENCİ TAKİP BİLGİLERİ"; 
                worksheet.Cells[1, 1, 1, 6].Merge = true; 

                worksheet.Cells[1, 7].Value = "Gönderilen Firma 1";
                worksheet.Cells[1, 7, 1, 10].Merge = true; 

                worksheet.Cells[1, 11].Value = "Gönderilen Firma 2";
                worksheet.Cells[1, 11, 1, 14].Merge = true; 

                worksheet.Cells[1, 15].Value = "Gönderilen Firma 3";
                worksheet.Cells[1, 15, 1, 18].Merge = true;

         
               //range değişkeniyle belirlenen aralıktaki hücrelere özellikler vermelmesi(1. ve 2. satırın özellikleri)
               //yazı rengi, font büyüklüğü,arkaplan rengi vb.
         
                var range = worksheet.Cells[1, 1, 2, 18];
                worksheet.Row(1).Height = 30;
                worksheet.Row(2).Height = 30;
                range.Style.Font.Bold = true;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(Color.Beige);
                range.Style.Font.Color.SetColor(Color.Black);
                range.Style.Font.Size = 13;
                range.Style.ShrinkToFit = false;

     
                //Excel dosyasında belirtilen satırlara belirtilen değerlerin yazılması.
           
                worksheet.Cells[2, 1].Value = "Öğrenci ID";
                worksheet.Cells[2, 2].Value = "Adı Soyadı";
                worksheet.Cells[2, 3].Value = "Şube";
                worksheet.Cells[2, 4].Value = "Aldığı Eğitim";
                worksheet.Cells[2, 5].Value = "Durumu";
                worksheet.Cells[2, 6].Value = "Rezerve Edildiği Firma Ünvanı";

                //Öğrencilerin bütün bilgilerinin alt alta listelenme işlemi, bundandır ki row++ yapmamız
                int row = 2;
                foreach (var student in students)
                {
                    row++;
                    worksheet.Cells[row, 1].Value = student.IdentityNumber;
                    worksheet.Cells[row, 2].Value = student.FullName;
                    worksheet.Cells[row, 3].Value = student.BranchName;
                    worksheet.Cells[row, 4].Value = student.EducationName;
                    worksheet.Cells[row, 5].Value = student.StudentWorkState;
                    worksheet.Cells[row, 6].Value = student.ReserverdCompanyName;

                    //3 görüşmenin de içeriğinin gömülme işlemi
                    int column = 7;
                    foreach (var interview in student.Interviews)
                    {
                        //3 görüşmenin içerikleri yan yana sıralanması
                        worksheet.Cells[row, column].Value = interview.Firm.Name;
                        worksheet.Cells[row, (column + 1)].Value = Convert.ToDateTime(interview.Date).ToShortDateString();
                        worksheet.Cells[row, (column + 2)].Value = interview.Description;
                        worksheet.Cells[row, (column + 3)].Value = Enum.GetName(typeof(ModelType), interview.ModelType);
                        column = column + 4;
                    }

                    //Her iki satırda bir satırın arkaplan rengini değiştirir, okunaklılık kolay olsun diye.
                    worksheet.Cells[row, 1, row, 18].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    var bgColor = row % 2 == 0 ? Color.WhiteSmoke : Color.White;
                    worksheet.Cells[row, 1, row, 18].Style.Fill.BackgroundColor.SetColor(bgColor);
                }

                //Son 3 görüşmenin başlıkları
                for (int i = 0; i < 12; i = i + 4)
                {
                    worksheet.Cells[2, 7 + i].Value = "Ünvan";
                    worksheet.Cells[2, 8 + i].Value = "Gönderildiği Tarih";
                    worksheet.Cells[2, 9 + i].Value = "Sonuç";
                    worksheet.Cells[2, 10 + i].Value = "Model";
                }

                //allCells değişkeni ile belirtilen aralıktaki hücrelere özellik ekleme işlemi
              
                var allCells = worksheet.Cells[1, 1, row, 18];
                var border = allCells.Style.Border;
                allCells.AutoFitColumns(40, 100);
                allCells.Style.VerticalAlignment = ExcelVerticalAlignment.Center; 
                allCells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                border.Bottom.Style = border.Top.Style = border.Left.Style = border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.DefaultRowHeight = 13;
                worksheet.Cells[1, 1, 2, 18].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[1, 1, 2, 18].Style.Font.Bold = true;

                //Dosyanın servera kaydedilmesi
                package.Save();

                //servera kaydedilen dosyanın yolu ve ismi
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "/App_Data/Export/", fileName);

                //ve dosya indirilir.
                return File(fullPath, "application/vnd.ms-excel", fileName);
            }
        }
    }
}


