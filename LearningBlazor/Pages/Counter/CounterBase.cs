using LearningBlazor.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningBlazor.Pages.Counter
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        protected readonly string caption = "Click me!";

        protected void IncrementCount()
        {
            currentCount++;
        }

        protected void NewPerson()
        {
            var person = new Guest();
            person.FirstName = "";
            person.LastName = "";

            person.Update();
        }
    }
}
