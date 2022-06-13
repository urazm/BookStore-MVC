namespace SemesterWork.BookStore.Helpers
{
    using SemesterWork.BookStore.Models;
    using System.ComponentModel.DataAnnotations;
    /*
     * 
     * Класс валидации на уровне модели 
     *
     */
    public class NamePasswordEqualAttribute : ValidationAttribute
    {
        public NamePasswordEqualAttribute()
        {
            ErrorMessage = "Имя и пароль не должны совпадать!";
        }
        public override bool IsValid(object value)
        {
            SignUpUserModel user = value as SignUpUserModel;

            if (user.Email == user.Password)
            {
                return false;
            }
            return true;
        }
    }
}
