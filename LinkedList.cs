using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_003
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            El_LinkedList stack = new El_LinkedList();
            Sp MySp = new Sp();
            int flag = 0;
            Console.Write("Enter the number of members List>>");
            int size1 = Int32.Parse(Console.ReadLine());
            if (size1 <= 0) Console.WriteLine("Not created? number el must be !=0");
            else
            { 
                for(int i=0;i<size1;i++)
                {
                    El_Stack mystack;
                    Console.Write("Введите количество элементов очереди №" + (i + 1) + " : ");
                    int size2 = Int32.Parse(Console.ReadLine());
                    Random rd = new Random();

                    for(int j=0;j<size2;j++)
                    {
                        int col = rd.Next(20);
                        mystack = new El_Stack(col);
                        stack.CountEl();
                        stack.EnQueue(mystack);

                    }
                   MySp.AddEl(stack);
                    stack = new El_LinkedList();
                    Console.WriteLine(MySp.ToString());
                }
                Console.Write("Желаете добавить элемент за определенным индексом? (1 - Да, 2 - Нет) :");
                int flag1 = Int32.Parse(Console.ReadLine());
                do
                {
                    int index_add;
                    if (flag1 == 1)
                    {
                        Console.Write("За каким индексом желаете добавить элемент листа? :");
                        index_add = Int32.Parse(Console.ReadLine());
                        if (index_add > MySp.CountEl()) Console.WriteLine("Элемент не был добавлен, так как такого индекса нету в листе!");
                        else
                        {
                            Console.Write("Введите количество элементов stack №" + (index_add) + " : ");
                            int size_add = Int32.Parse(Console.ReadLine());
                            Random rd = new Random();
                            for(int j=0;j<size_add;j++)
                            {
                                El_Stack mystack;
                                int col = rd.Next(20);
                                mystack = new El_Stack(col);
                                
                                stack.EnQueue(mystack);
                            }
                            MySp.InsertEl(index_add, stack);
                        }
                        Console.Write("Желаете добавить элемент за определенным индексом? (1 - Да, 2 - Нет) :");
                        flag = Int32.Parse(Console.ReadLine());
                    }
                } while (flag==1);

                Console.WriteLine("Начальный Лист stack`ov проинициализирован и имеет вид");
                Console.WriteLine(MySp.ToString());
                Console.Write("Желаете удалить элемент Листа? (1 - Да, 2 - Нет) : ");
                int flag_del = Int32.Parse(Console.ReadLine());
                if (flag_del == 1)
                {
                    Console.WriteLine("Сколько элементов желаете удалить?");
                    int count_del = Int32.Parse(Console.ReadLine());
                    if (count_del >= MySp.CountEl())
                    {
                        MySp.ClearEl();
                        Console.WriteLine("Clear list sucsessfully!");

                    }
                    else
                    {
                       for (int i = 0; i < count_del; i++)
                           MySp.RemoveEl(stack);
                    }

                }
                Console.WriteLine("Лист очередей проинициализирован и имеет вид");
                Console.WriteLine(MySp.ToString());
                Console.Write("Желаете удалить элемент за определенным индексом? (1 - Да, 2 - Нет) :");
                int flag_del_indx = Int32.Parse(Console.ReadLine());
                if (flag_del_indx==1)
                {
                    Console.Write("За каким индексом желаете удалить элемент листа?");
                    int index_del = Int32.Parse(Console.ReadLine());
                    if (index_del<=MySp.CountEl())
                    {
                        MySp.RemoveAtEl(index_del);

                    }
                    else
                    {
                        Console.WriteLine("El not deleted because count is so small");
                    }
                }
                int count = MySp.CountEl();

                Console.Write("Желаете удалить элемент очереди №" + count-- + " (1 - Да, 2 - Нет) : ");
                int flag_del_el_stack = Int32.Parse(Console.ReadLine());
                if (flag_del_el_stack==1)
                {
                    Console.WriteLine("Сколько элементов желаете удалить?");
                    int del_stack = Int32.Parse(Console.ReadLine());
                    if (del_stack>=stack.CountEl())
                    {
                        stack.ClearEl();
                        Console.WriteLine("Stack was cleared!");
                    }
                    else
                    {
                        for (int i =0;i<del_stack;i++)
                        {
                            stack.Dequeue();
                        }

                    }
                    if (MySp.LinkedListIsEmpty()) Console.WriteLine("Лист пустой!");
                    else
                    {
                       Console.WriteLine("Лист очередей после изменений не пустой и имеет вид");
                        int k = MySp.CountEl();
                        Console.WriteLine(MySp.ToString());
                    }

                }
            }

        }
    }
}
