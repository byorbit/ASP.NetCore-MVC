using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Models.ModelMetadataTypes
{
    //ProductMetadata sınıfı Product sınıfına ait validation'ları ayrı yönetmek için oluşturulmaktadır.
    //Single Responsibility Princible(bir sınıfın tek bir sorumluluk alması prensibine uygun olması amaçlanmaktadır.
    //Ama istenirse bu validationlar Product sınıfında da oluşturulabilmekteder. Her ne kadar tavsiye edilmesede...
    
    public class ProductMetadata
    {
        [Required(ErrorMessage = "Lutfen ürün ismi giriniz")] //Server tarafında client mesajları olusturuyoruz.
        [StringLength(10, ErrorMessage = "Lutfen en fazla 100 karakter giriniz")]
        public string ProductName { get; set; }
  
        [EmailAddress(ErrorMessage = "Lutfen dogru bir email adresi giriniz")]
        public string Email { get; set; }
    }
}
