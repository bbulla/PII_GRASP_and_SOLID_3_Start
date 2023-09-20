using System;
using System.IO;

// Ahora que deefiní la interfaz IPrinter, puedo definir las clases ConsolePrinter y FilePrinter y que las mismas hereden de Iprinter
// lo necesario para poder imprimir la receta en consola o en un archivo de texto.
namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}