Testowanie Automatyczne z Uzyciem xUnit.net oraz IntelliTest 
Rozwiazanie wykonane w Visual Studio Profesional 2019 (IntelliTest nie dostepna dla Visual Studio Comunity) 
 ![X Unit](Photo/XUnit.png)

1 Utw�rz nawy Projekt Bibliteka Klas(Standard) o nazwie SomeLibary
![Create Project](Photo/create_project.png)

2 Dodaj prost� klase dodawanie Imienia 

using System;

namespace SomeLibary
{
    public class AddName
    {
        public string GetName(string name) 
        {
            return $"Pan {name}";
        }
    }
}

3 Dodaj nowy projekt testowy xUnit o nazwie SomeLibary.Unit.Test
![New Project Test](Photo/addProjectXunitTest.png)

4 Dodaj owo�anie do metod klasy SomeLibary
![Add Dependency Base Project](Photo/add_dependecy.png)

5 Utw�rz kalse testow� o nazwie DoSomeTest

using System;
using Xunit;

namespace SomeLibary.Unit.Test
{
    public class DoSomeTest
    {
        [Fact]
        public void SholuldRerurnName()
        {
            //given 
            string name = "Artur";
            string expectedName = "Pan Artur";
            var doStuff = new  AddName();

            //when 
          string actualName = doStuff.GetName(name);

            //then
            Assert.Equal(expectedName, actualName);
        }
    }
} 

6 uruchom testy sk�rt klawiszowy: (crt + r + t)

