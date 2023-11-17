namespace InputValidation;

public class Validator : IValidator
{
  public bool IsValidEmail(string email)
  {
        bool isValid;
        if (email == null || email.Length == 0) isValid = false;
        else if (!email.Contains('@')) isValid = false;
        else if (email[0] == '@') isValid = false;
        else if (!email.Split('@')[1].Contains('.') || !char.IsLetter(email[^1])) isValid = false;
        else isValid = true;


        return isValid;
  }
}
