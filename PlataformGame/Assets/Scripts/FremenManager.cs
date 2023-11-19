using System.Linq;
using Unity.VisualScripting;
public static class FremenManager{
    // estatisticas das fases
    public static SpaceGuild leto = new SpaceGuild();

    public static void resetPontuacoes(){
        leto = new SpaceGuild();
    }
}