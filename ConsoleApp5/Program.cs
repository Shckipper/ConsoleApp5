using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrganizer
{
    
        class Program
        {
            static void Main(string[] args)
            {
                List<string> notes = new List<string>();
                bool isRunning = true;

                Console.WriteLine("=== Добро пожаловать в органайзер ===");

                while (isRunning)
                {
                    try
                    {
                        Console.WriteLine("\nВыберите действие:");
                        Console.WriteLine("1 - Добавить заметку");
                        Console.WriteLine("2 - Просмотреть все заметки");
                        Console.WriteLine("3 - Завершить работу");
                        Console.Write("Ваш выбор: ");

                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.Write("Введите текст заметки: ");
                                string note = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(note))
                                {
                                    throw new ArgumentException("Заметка не может быть пустой.");
                                }

                                notes.Add(note);
                                Console.WriteLine("Заметка успешно добавлена!");
                                break;

                            case "2":
                                Console.WriteLine("\nВаши заметки:");
                                if (notes.Count == 0)
                                {
                                    Console.WriteLine("У вас пока нет заметок.");
                                }
                                else
                                {
                                    for (int i = 0; i < notes.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {notes[i]}");
                                    }
                                }
                                break;

                            case "3":
                                Console.WriteLine("Спасибо за использование органайзера! До свидания.");
                                isRunning = false;
                                break;

                            default:
                                Console.WriteLine("Ошибка: выбрано некорректное действие. Попробуйте снова.");
                                break;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                    }
                }
            }
        }
    

}
