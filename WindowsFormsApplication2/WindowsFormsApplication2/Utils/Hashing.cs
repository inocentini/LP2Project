using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApplication2
{
    class Hashing
    {
        //Classe utilizada para o hashing e salting
        private const int MINSALT = 4; //mínimo do intervalo de aleatoriedade do salt
        private const int MAXSALT = 16; //máximo do intervalo de aleatoriedade do salt
        private const int TAMANHOHASH = 32;

        public static string Hash(string senha,byte[] salt) //Método utilizado para realizar o hashing em uma senha
        {
            byte[] bytesSalt = null;

            if(salt != null)
            {
                //Se o salt já existir, define a variável bytesSalt como o parâmetro para a geração do hash com o salt já disponível
                bytesSalt = salt;
            }
            else
            {
                //Se não existir, o programa gerará valores aleatórios que serão utilizados no salt
                Random r = new Random();
                int tamanhoSalt = r.Next(MINSALT, MAXSALT);
                bytesSalt = new byte[tamanhoSalt];

                //É instanciado um objeto RNGCryptoServiceProvider e preenchido o vetor de bytes com uma sequência criptografada de bytes
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(bytesSalt);
                rng.Dispose();
            }

            //A senha informada é transformada em um vetor de bytes e é adicionado o salt
            byte[] bytesSenha = ASCIIEncoding.UTF8.GetBytes(senha);
            byte[] bytesSenhaComSalt = new byte[bytesSenha.Length + bytesSalt.Length];

            for(int x=0; x<bytesSenha.Length; x++)
            {
                bytesSenhaComSalt[x] = bytesSenha[x];
            }

            for(int n=0; n<bytesSalt.Length; n++)
            {
                bytesSenhaComSalt[bytesSenha.Length + n] = bytesSalt[n];
            }

            //É instanciado o objeto de encriptação SHA256 e realizada a encriptação
            byte[] valorHash = null;

            SHA256Managed sha = new SHA256Managed();
            valorHash = sha.ComputeHash(bytesSenhaComSalt);
            sha.Dispose();

            //Por fim, é criado o vetor de bytes do resultado, que contém a senha encriptada anteriormente e o salt
            byte[] resultado = new byte[valorHash.Length + bytesSalt.Length];

            for(int x=0; x<valorHash.Length; x++)
            {
                resultado[x] = valorHash[x];
            }

            for(int n=0; n<bytesSalt.Length; n++)
            {
                resultado[valorHash.Length + n] = bytesSalt[n];
            }

            //É convertido e retornado o vetor de bytes do resultado para uma string de base 64
            return Convert.ToBase64String(resultado);
        }

        public static bool Verifica(string senha,string valorHash)
        {
            //É convertido para bytes a string do hash
            byte[] bytesHash = Convert.FromBase64String(valorHash);

            //É criado o vetor de bytes que será usado para o salt
            byte[] bytesSalt = new byte[bytesHash.Length - TAMANHOHASH];

            //É obtido o salt a partir do fim da string encriptada do hash até o fim do mesmo
            for(int x=0; x<bytesSalt.Length; x++)
            {
                bytesSalt[x] = bytesHash[TAMANHOHASH + x];
            }

            //É criado um hash temporário com os dados obtidos anteriormente
            string hashTemp = Hash(senha,bytesSalt);

            //Retorna true se o hash informado for o mesmo da senha e false senão
            return (valorHash == hashTemp);
        }
    }
}
