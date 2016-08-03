using System.ComponentModel.DataAnnotations;

namespace ProjectTemplate.Core.Enums
{//İş türünü enumda tutuyoruz
    public enum ModelType
    {
        [Display(Name = "İş Başı Eğitimi")]
        IsBasiEgitimi=1,

        [Display(Name = "BA Outsource ile")]
        BAOutsourceIle=2,

        [Display(Name = "BA Seçme Yerleştirme ile")]
        BASecmeYerlestirmeIle=3
    }
}
