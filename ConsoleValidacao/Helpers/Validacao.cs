using System;

namespace ConsoleValidacao.Helpers
{
    public class Validacao
    {
        public static bool CPFisValid(string cpf)
        {
            if (cpf == "")
                return false;

            if (cpf.Length != 11)
                return false;

            switch (cpf)
            {
                case "00000000000":
                    return false;

                case "11111111111":
                    return false;

                case "22222222222":
                    return false;

                case "33333333333":
                    return false;

                case "44444444444":
                    return false;

                case "55555555555":
                    return false;

                case "66666666666":
                    return false;

                case "77777777777":
                    return false;

                case "88888888888":
                    return false;

                case "99999999999":
                    return false;
            }

            string cpfCalculado;

            int digito1, digito2;
            int soma = 0;
            int resto = 0;

            int[] constante1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] constante2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] algarismoCpf = new int[11];

            try
            {
                algarismoCpf[0] = Convert.ToInt32(cpf.Substring(0, 1));
                algarismoCpf[1] = Convert.ToInt32(cpf.Substring(1, 1));
                algarismoCpf[2] = Convert.ToInt32(cpf.Substring(2, 1));
                algarismoCpf[3] = Convert.ToInt32(cpf.Substring(3, 1));
                algarismoCpf[4] = Convert.ToInt32(cpf.Substring(4, 1));
                algarismoCpf[5] = Convert.ToInt32(cpf.Substring(5, 1));
                algarismoCpf[6] = Convert.ToInt32(cpf.Substring(6, 1));
                algarismoCpf[7] = Convert.ToInt32(cpf.Substring(7, 1));
                algarismoCpf[8] = Convert.ToInt32(cpf.Substring(8, 1));
                algarismoCpf[9] = Convert.ToInt32(cpf.Substring(9, 1));
                algarismoCpf[10] = Convert.ToInt32(cpf.Substring(10, 1));
            }
            catch
            {
                return false;
            }

            //Verificando primeiro dígito
            for (int i = 0; i <= constante1.GetUpperBound(0); i++)
                soma += constante1[i] * algarismoCpf[i];

            resto = soma % 11;

            if (resto == 1 || resto == 0)
                digito1 = 0;
            else
                digito1 = 11 - resto;

            soma = 0;

            //Verificando segundo dígito
            for (int i = 0; i <= constante2.GetUpperBound(0); i++)
                soma += constante2[i] * algarismoCpf[i];

            resto = soma % 11;

            if (resto == 1 || resto == 0)
                digito2 = 0;
            else
                digito2 = 11 - resto;


            cpfCalculado = digito1.ToString() + digito2.ToString();
            cpf = algarismoCpf[9].ToString() + algarismoCpf[10].ToString();

            if (cpfCalculado == cpf)
                return true;
            else
                return false;
        }
    }
}
