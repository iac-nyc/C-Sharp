List<int> numbers = new List<int>{2,4,5,6,9}                                             
List<int> numberGreatherThanFive = new List<int>();                                      
foreach(int number in numbers)                                                           
      {                                                                                        
           if(number>5)                                                                             
           {                                                                                        
           numberGreatherThanFive.Add(number);                                                      
           }                                                                                        
       }                                                                                        
numberGreatherThanFive // { 6, 9 }  

// LINQ

from number in numbers 
where number > 5 
select number;        // { 6, 9 }
