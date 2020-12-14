namespace ConversorDeMoeda.classes
{
    public static class Conversor
    {
        private static float cotacaoReal = 0.2f;
        private static float cotacaoEuro = 1.22f;
        public static float RealParaDolar(float valor){
            return valor / cotacaoReal;
        }
        public static float DolarParaReal(float valor){
            return valor * cotacaoReal;
        }
        public static float DolarParaEuro(float valor){
            return valor / cotacaoEuro;
        }
        public static float EuroParaDolar(float valor){
            return valor * cotacaoEuro;
        }
    }
}