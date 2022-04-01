using System;

namespace ITOffice
{
    /* Разработать классы для программы управления ИТ офисом.
1. Класс Office содержит список Employee, сотрудники бывают QAEmployee, DevEmployee, BAEmployee, PMEmployee, QAAutomationEmployee, QAAutomationTeamLead, DevTEamLead, QATeamLead.
2. Ассайнить таски могут тимлиды и PMEmployee, делать ревью кода тимлиды QAAutomation и Dev.
3. Писать код могут Dev, QAAuto и их тимлиды.
4. Заполнить список Employee специалистами разного профиля, и вывести подробную информацию о специлистах, которые могут
4.1 писать код
4.2 ассайнить таски
4.3 делать ревью кода*/

    class Program
    {
        static void Main(string[] args)
        {
            ITOfficeIssoft issoft = new ITOfficeIssoft();
            issoft.Employees.Add(new DevEmployee());
            issoft.Employees.Add(new QAEmployee());
            issoft.Employees.Add(new BAEmployee());
            issoft.Employees.Add(new PMEmployee());
            issoft.Employees.Add(new QAAutomationEmployee());
            issoft.Employees.Add(new QAAutomationTeamLead());
            issoft.Employees.Add(new DevTeamLead());
            issoft.Employees.Add(new QATeamLead());


            foreach (Employee employee in issoft.Employees)
            {
                /*Console.WriteLine(employee.Greetings());*/
                if (employee is ITaskAssigner)
                {
                    Console.WriteLine((employee as ITaskAssigner).AssignTask());

                }
            }

            foreach (Employee employee in issoft.Employees)
            {

                if (employee is ICodeReviewer)
                {
                    Console.WriteLine((employee as ICodeReviewer).ReviewCode());

                }
            }

            foreach (Employee employee in issoft.Employees)
            {

                if (employee is ICodeWriter)
                {
                    Console.WriteLine((employee as ICodeWriter).WriteCode());

                }
            }
        }
    }
}
