﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_3();
        }
        public static void Task_1()
        {
            string inp = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";
            var a = new Purple_1(inp);
            string outt = "еовреП еонтевсогурк еивтсешетуп олыб онелвтсещусо мотолф, мымеялвалгзов миксьлагутроп мелетаводелсси монанреФ моналлегаМ. еивтсешетуП ьсолачан 20 ярбятнес 1519 адог, адгок толф, йищяотсос зи итяп йелбарок и онремирп 270 кеволеч, ясливарпто зи утроп сакуЛ-наС в иинапсИ. ятоХ наллегаМ ен личноказ еовс еивтсешетуп аз-зи илебиг в евтиб ан ханиппилиФ в 1521 удог, оге яицидепскэ алатс йовреп, яароток оншепсу алунгобо юлмеЗ и алазакод ее юулгурк умроф. отЭ еивтсешетуп олыркто еывон еиксром итуп и олеми еонморго еинечанз ялд иифарготрак и хиксечифаргоег йитыркто.";
            a.Review();
            for (int i = 0; i < inp.Length; i++)
            {
                if (a.Output[i] != outt[i])
                {
                    for (int j = 110; j < 140; j++)
                        Console.Write(a.Output[j]);
                    Console.WriteLine();
                    for (int j = 110; j < 140; j++)
                        Console.Write(outt[j]);
                    Console.WriteLine();
                    Console.WriteLine(a.Output[i]);
                    Console.WriteLine(outt[i]);
                    Console.WriteLine(i);
                    Console.WriteLine("ОШИБКААААА");
                    break;
                }
            }
        }
        public static void Task_2()
        {
            string inp = null;
            var a = new Purple_2(inp);
            string outt = "Фьорды  –  это  ущелья,  формирующиеся ледниками и\r\nзаполняющиеся  морской  водой. Название происходит\r\nот   древнескандинавского   слова   \"fjǫrðr\".  Эти\r\nглубокие   заливы,   окруженные  высокими  горами,\r\nпредставляют   захватывающие   виды   и  природную\r\nкрасоту.  Они  популярны среди туристов и известны\r\nпод  разными  названиями: в Норвегии – \"фьорды\", в\r\nШотландии  –  \"фьордс\",  в  Исландии  – \"фьордар\".\r\nФьорды  играют  важную  роль  в культуре и туризме\r\nрегиона,  продолжая  вдохновлять  людей  со  всего\r\nмира..";
            a.Review();

            foreach(var i in a.Output)
                Console.WriteLine(i);
            for (int i = 0; i < inp.Length; i++)
            {
                if (a.ToString()[i] != outt[i])
                {
                    /*for (int j = 110; j < 140; j++)
                        Console.Write(a.Output[j]);
                    Console.WriteLine();
                    for (int j = 110; j < 140; j++)
                        Console.Write(outt[j]);
                    Console.WriteLine();*/
                    Console.WriteLine(a.ToString()[i]);
                    Console.WriteLine(outt[i].ToString());
                    Console.WriteLine(i.ToString());
                    Console.WriteLine("ОШИБКААААА");
                    break;
                }
            }
        }
        public static void Task_3()
        {
            string inp = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";
            var a = new Purple_3(inp);
            string outt = "Первое кругосвет!е путеше\"вие бы# осуще\"вле! ф#том, возглавляемым португальским исследователем Ферна!м Магелла!м. Путеше\"вие нача#сь 20 сентября 1519 года, когда ф#т, со\"оящий из пяти кораблей и пример! 270 че#век, $правился из порту Сан-Лукас в Испании. Х$я Магеллан не закончил свое путеше\"вие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция \"ала первой, к$орая успеш! обогнула Землю и доказала ее круглую форму. Это путеше\"вие $кры# !вые морские пути и име# огром!е значение для картографии и географич%ких $крытий.";
            a.Review();
            for (int i = 0; i < outt.Length; i++)
            {
                if (a.ToString()[i] != outt[i])
                {
                    /*for (int j = 110; j < 140; j++)
                        Console.Write(a.Output[j]);
                    Console.WriteLine();
                    for (int j = 110; j < 140; j++)
                        Console.Write(outt[j]);
                    Console.WriteLine();*/
                    Console.WriteLine(a.ToString()[i]);
                    Console.WriteLine(outt[i].ToString());
                    Console.WriteLine(i.ToString());
                    Console.WriteLine("ОШИБКААААА");
                    break;
                }
            }
        }
        public static void Task_4()
        {
            string inp = "Первое кругосвет!е путеше\"вие бы# осуще\"вле! ф#том, возглавляемым португальским исследователем Ферна!м Магелла!м. Путеше\"вие нача#сь 20 сентября 1519 года, когда ф#т, со\"оящий из пяти кораблей и пример! 270 че#век, $правился из порту Сан-Лукас в Испании. Х$я Магеллан не закончил свое путеше\"вие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция \"ала первой, к$орая успеш! обогнула Землю и доказала ее круглую форму. Это путеше\"вие $кры# !вые морские пути и име# огром!е значение для картографии и географич%ких $крытий.";
            var a = new Purple_3(inp);
            string outt = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";
            a.Review();
            for (int i = 0; i < outt.Length; i++)
            {
                if (a.ToString()[i] != outt[i])
                {
                    /*for (int j = 110; j < 140; j++)
                        Console.Write(a.Output[j]);
                    Console.WriteLine();
                    for (int j = 110; j < 140; j++)
                        Console.Write(outt[j]);
                    Console.WriteLine();*/
                    Console.WriteLine(a.ToString()[i]);
                    Console.WriteLine(outt[i].ToString());
                    Console.WriteLine(i.ToString());
                    Console.WriteLine("ОШИБКААААА");
                    break;
                }
            }
        }
    }
    
}
