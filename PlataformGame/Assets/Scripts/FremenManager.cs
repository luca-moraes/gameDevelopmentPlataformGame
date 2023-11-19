using System.Linq;
using Unity.VisualScripting;
public static class FremenManager{
    // estatisticas das fases
    public static SpaceGuild leto = new SpaceGuild();

    public static void resetAll(){
        leto = new SpaceGuild();
    }

    public static void resetFase(){
        leto.jessica = 3;
        leto.spice = leto.spice == 0 ? 0 : leto.spice - 1;
    }
}