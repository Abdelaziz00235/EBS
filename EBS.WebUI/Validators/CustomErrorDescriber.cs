using Microsoft.AspNetCore.Identity;

namespace EBS.WebUI.Validators
{
    public class CustomErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Description = "Au moins un chiffre"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Description = "Au moins une lettre minuscule (a-z)"
            };
        }
        public override IdentityError PasswordRequiresUpper() 
        {
            return new IdentityError
            {
                Description = "Au moins une lettre majiscule (A-Z)"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Description = "Au moins un caractere Aplphanumerique ( , . - + @ * % & etc.)"
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Description = $"Au moins {length} Caractere."
            };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Description = $"{userName} est deja utiliser."
               
            };
        }
    }
}
