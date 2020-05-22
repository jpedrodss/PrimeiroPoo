namespace PrimeiroPOO
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public int armadura;

        public int Atacar(int forca, int potencia){
            return forca * potencia;
        }

        public string Defender(){
            return "Ataque defendido com Sucesso";
        }
    }
}