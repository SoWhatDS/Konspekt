using System;
using System.IO;
using UnityEngine;

namespace ExceptionTest
{
    internal sealed class TestException : MonoBehaviour
    {
        private void Start()
        {
            StreamWriter sw = null;

            //контролируемый блок
            try
            {
                //программные инструкции которые необходимо проконтролировать
                var path = Path.Combine(@"C:\", "temp", "text.txt");
                sw = new StreamWriter(path);
                int a;
                do
                {
                    a = Convert.ToInt32(1);
                    sw.WriteLine(a);
                } while (a != 0);
            }
            //один или несколько блоков обработки исключений
            catch (FormatException)
            {
                Debug.Log("Ошибка ввода данных");
            }
            catch (IOException)
            {
                Debug.Log("Ошибка ввода/вывода данных");
            }
            catch (Exception exc)
            {
                Debug.Log("Неизвестная ошибка");
                Debug.Log("Информация об ошибке " + exc.Message);
            }
            //блок завершения(помещается код, который должен быть обязательно выполнен при выходе из блока try)
            finally
            {
                //использование блока finally гарантирует, что набор операторов будет выполняться всегда
                //независимо от того, возникло исключение любого типа или нет
                sw?.Close();
            }
        }
    }
}
