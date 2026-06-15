using ControleDeFuncionarios.Controllers;

namespace ControleDeFuncionarios
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
            var controller = new FuncionarioController();
            controller.cadastrarFuncionario();

        }
    }
}
