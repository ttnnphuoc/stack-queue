using StackAndQueueExample;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("------QUEUE--FIFO-----");
QueueAndStack.ExampleQueue();

Console.WriteLine("------STACK--LIFO-----");
QueueAndStack.ExampleStack();

Console.WriteLine(QueueAndStack.isValidString("()"));
Console.WriteLine(QueueAndStack.isValidString("([)]"));
Console.WriteLine(QueueAndStack.isValidString("{[]}"));
Console.WriteLine(QueueAndStack.isValidString("(]"));