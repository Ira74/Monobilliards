using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace Monobilliards
{
    public class Monobilliards : IMonobilliards
    {
        //Задание
        //В классе Monobillards реализуйте метод IsCheater, 
        //на вход которому подается список шаров в порядке извлечения их 
        //из лузы ревизором.Верните true, если Чичиков не мог закатить шары в правильном порядке.
        //Иначе верните false.
        //Решение(выполнено самостоятельно):

        public bool IsCheater(IList<int> inspectedBalls) //на вход подается список шаров в порядке извлечения их из лузы ревизором
                                                         // вернуть true, если Чичиков не мог закатить шары в правильном порялке, иначе false
        {
            var originalBalls = new Stack<int>();

            if (inspectedBalls.Count == 0)
            {
                return false;
            }

            int count = 0;

            for (int i = 0; i < inspectedBalls.Count; i++)
            {
                originalBalls.Push(i + 1);

                while (originalBalls.Count != 0 && inspectedBalls[count] == originalBalls.Peek())
                {
                    originalBalls.Pop();
                    count++;
                    if (inspectedBalls.Count == count)
                        return false;
                }
            }

            return true;
        }

    }
}

