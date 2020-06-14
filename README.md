# YesSoftTest

## SOLID used
<ul>
 <li>DI Principle</li>
 <li>LS Principle</li>
 <li>IS Principle</li>
</ul>

## Design Patterns used

<ul>
  <li>Dispatcher</li>
  <li>Fluent Builder</li>
</ul>

## Add new rule is very easy

just create new class and implemnet IDivisable interface with your logic

for example 
```csharp
namespace YesSoftTest{
    public class Dby19 : IDivisable<Dby19>
    {
        public void Divisable(EvNum ev)
        {
            if(ev.Num % 19 == 0){
                Console.WriteLine("Yes Soft");
            }
        }
    }
}
```
