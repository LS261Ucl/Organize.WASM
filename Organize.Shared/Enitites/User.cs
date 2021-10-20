using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Organize.Shared.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organize.Shared.Enitites
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(10, ErrorMessage ="User name is too long.")]
        public string UserName{ get; set; }

        [Required(ErrorMessage = "The Password is requried!!!")]
        public string Password { get; set; }
        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public GenderTypeEnum GenderType { get; set; }

        public ObservableCollection<BaseItem> UserItems { get; set; }

        public override string ToString()
        {
            var salutaion = string.Empty;

            if(GenderType == GenderTypeEnum.Male)
            {
                salutaion = "Mr";
            }


            if (GenderType == GenderTypeEnum.Female)
            {
                salutaion = "Mrs";
            }

            return $"{salutaion}. {FirstName} {LastName}";
        }


    }
}
