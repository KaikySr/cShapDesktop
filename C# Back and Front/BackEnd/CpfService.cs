public class CpfService
{
    private int getVerificationDigits(Cpf cpf)
    {
        var str = cpf.Value;
        int sum = 0;

        for (int i = 0; i < 8; i++)
        {
            int digit = str[i] - '0';
            sum += (i + 2) * digit;
        }

        int verifier1 = sum % 11;

        for (int i = 0; i < 8; i++)
        {
            int digit = str[i] - '0';
            sum -= digit;
        }

        sum += 9 * verifier1;

        int verifier2 = sum % 11;

        return 10 * verifier1 + verifier2;
    }
    public void Validate(Cpf cpf)
    {
        if (cpf is null)
            throw new ArgumentNullException("cpf");

        int verifier = getVerificationDigits(cpf);

        bool isValid = verifier == cpf.VerificationDigit;

        cpf.Verified = true;
        cpf.Validated = isValid;
    }
    public Cpf Generate(int region = -1)
    {
        Cpf cpf = new Cpf();

        if (region == -1)
            region = Random.Shared.Next(10);

        cpf.FiscalRegionDigit = region;
        cpf.RandomDigits = Random.Shared.Next(100_000_000);
        cpf.VerificationDigit = getVerificationDigits(cpf);
        cpf.Verified = true;
        cpf.Validated = true;

        return cpf;
    }
}
public class Cpf
{
    public string Value
    {
        get => $"{RandomDigits:000.000.00}{FiscalRegionDigit}-{VerificationDigit:00}";
        
        set
        {
            if (value is null)
                throw new InvalidCastException("Value can't be null.");

            value = value
                .Replace("-", "")
                .Replace(".", "");

            if (value.Length != 11)
                throw new InvalidCastException("Invalid number of digits.");

            RandomDigits = int.Parse(value.Substring(0, 8));
            FiscalRegionDigit = int.Parse(value.Substring(8, 1));
            VerificationDigit = int.Parse(value.Substring(9, 2));
        }
    }
    public string Region
    {
        get => FiscalRegionDigit switch
        {
            1 => "DF, GO, MT, MS e TO",
            2 => "AC, AP, AM, PA, RO e RR",
            3 => "CE, MA e PI",
            4 => "AL, PB, PE e RN",
            5 => "BA e SE",
            6 => "MG",
            7 => "ES e RJ",
            8 => "SP",
            9 => "PR e SC",
            10 => "RS",
            _ => "Região desconhecida"
        };
    }
    public int RandomDigits { get; set; }
    public int FiscalRegionDigit { get; set; }
    public int VerificationDigit { get; set; }
    public bool Verified { get; set; } = false;
    public bool Validated { get; set; } = false;
}