using System.ComponentModel.DataAnnotations;

namespace Lesson08.Models
   
{
    public class KntAccount
    {
        [Key]
        [
            Display(Name = "ID"),
        ]
        public int KntId { get; set; }
        [
            Display(Name = "Họ và tên"),
            Required(ErrorMessage = "Họ tên không được để trống"),
            MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 kí tự"),
            MaxLength(20, ErrorMessage = "Họ tên tối đa là 20 kí tự")
        ]
        public string KntFullName { get; set; }
        [
            Display(Name = "Email"),
            Required(ErrorMessage = "Email không được để trống"),
            EmailAddress(ErrorMessage = "Email không đúng định dạng"),
        ]
        public string KntEmail { get; set; } = string.Empty;
        [
            Display(Name = "Số điện thoại"),
            DataType(DataType.PhoneNumber),
            RegularExpression(@"^(\+84|0)(\d{9,10})$", ErrorMessage = "Số điện thoại không đúng định dạng"),
            Required(ErrorMessage = "Số điện thoại không được để trống"),
        ]
        public string KntPhone { get; set; } = string.Empty;
        [
            Display(Name = "Địa chỉ"),
            Required(ErrorMessage = "Địa chỉ không được để trống"),
            StringLength(35, ErrorMessage = "Địa chỉ tối đa là 35 kí tự")
        ]
        public string KntAddress { get; set; } = string.Empty;
        [
            Display(Name = "Ảnh đại diện"),
        ]
        public string KntAvatar { get; set; } = string.Empty;
        [
            Display(Name = "Ngày sinh"),
            DataType(DataType.Date),
            Required(ErrorMessage = "Ngày sinh không được để trống")
        ]
        public DateTime KntBirthday { get; set; } = DateTime.MinValue;
        [
            Display(Name = "Giới tính"),
            Required(ErrorMessage = "Giới tính không được để trống")
        ]
        public string KntGender { get; set; } = string.Empty;
        [
            Display(Name = "Mật khẩu"),
            DataType(DataType.Password),
            Required(ErrorMessage = "Mật khẩu không được để trống"),
        ]
        public string KntPassword { get; set; } = string.Empty;
        [
            Display(Name = "Link Facebook"),
            Required(ErrorMessage = "Facebook link không được để trống"),
            Url(ErrorMessage = "Đường dẫn không đúng định dạng"),
        ]
        public string KntFacebook { get; set; } = string.Empty;

    }
}
