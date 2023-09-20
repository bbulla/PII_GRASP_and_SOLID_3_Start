using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

    // Defino la interfaz IPrinter para luego poder definir las clases ConsolePrinter y 
    //FilePrinter y que las mismas cumplan con los principios SOLID.
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}