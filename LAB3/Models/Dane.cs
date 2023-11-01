using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LAB3.Models
{

    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2, ErrorMessage = "Pole Imie wymaga minimalnie 2 znaków")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Pole email nie jest prawidłowym adresem email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj haslo")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "Hasło musi zawierać 8 znaków oraz przynajmniej zawierając jedną mała oraz dużą litere oraz 1 cyfre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Wpisz potwierdzenie hasła")]
        [Compare("Password", ErrorMessage = "Hasła różnią się od siebie")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Prosze podaj numer telefonu")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]{9}", ErrorMessage = "Numer telefonu może zawierać tylko cyfry")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Podaj swój wiek")]
        [RegularExpression("[0-9]{3}", ErrorMessage = "Nieprawidłowe dane dla wieku")]
        [Range(10, 80, ErrorMessage = "Twój wiek musi być większy od 10 ale mniejszy od 80")]
        public int Age { get; set; }

        public string City { get; set; }

        public enum Cities
        {
            Warsaw,
            Krakow,
            Gdansk,
            Wroclaw,
            Poznan
        }
    }
}

