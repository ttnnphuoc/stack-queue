using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueExample
{
    public static class QueueAndStack
    {

        /// <summary>
        /// Hàng đợi là mô hình FIFO (first in, first out - vào trước, ra trước)
        /// hay đến trước được phục vụ trước, nó giải quyết các bài toán thực tế giống như xếp hàng mua vé máy bay
        /// Count: Thuộc tính lấy tổng số phần tử trong hàng
        /// Enqueue: vào xếp hàng - đưa phần tử vào cuối hàng đợi
        /// Dequeue: đọc - và xóa ngay phần tử ở đầu hàng đợi - lỗi nếu hàng đợi không có phần tử nào
        /// Peek: đọc phần tử đầu hàng đợi
        /// </summary>
        public static void ExampleQueue()
        {
            Queue<string> hoso_canxuly = new Queue<string>();

            hoso_canxuly.Enqueue("Hồ sơ A"); // Hồ sơ xếp thứ nhất trong hàng đợi
            hoso_canxuly.Enqueue("Hồ sơ B"); // Hồ sơ xếp thứ hai
            hoso_canxuly.Enqueue("Hồ sơ C");

            // Lấy hồ sơ xếp trước xử lý  trước, cho đến hết
            while (hoso_canxuly.Count > 0)
            {
                var hs = hoso_canxuly.Dequeue();
                Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
            }
        }

        /// <summary>
        /// Ngăn xếp stack khá giống hàng đợi, nhưng khác đó là LIFO (last in, first out) - vào sau thì ra trước, 
        /// nó giống như xếp hàng hóa vào các container, vào nhà kho - 
        /// cái nào đưa vào sau thì khi thảo dỡ lại thực hiện đầu tiên, 
        /// nó giống như xếp đĩa vào cọc đĩa CD cái nào đưa vào cọc trước sẽ được lấy ra sau ...
        /// Count:	Thuộc tính lấy tổng số phần tử trong hàng
        /// Push: đẩy(thêm) một phần tử vào đỉnh stack
        /// Pop: đọc - xóa phần tử đỉnh stack
        /// Peek: đọc phần tử đỉnh stack
        /// Contains: kiểm tra một phần tử có trong stack hay không
        /// </summary>
        public static void ExampleStack()
        {
            Stack<string> hoso_canxuly = new Stack<string>();

            hoso_canxuly.Push("Hồ sơ A"); // Hồ sơ xếp thứ nhất trong hàng đợi
            hoso_canxuly.Push("Hồ sơ B"); // Hồ sơ xếp thứ hai
            hoso_canxuly.Push("Hồ sơ C");


            // Lấy hồ sơ xếp trước xử lý  trước, cho đến hết
            while (hoso_canxuly.Count > 0)
            {
                var hs = hoso_canxuly.Pop();
                Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
            }
        }

        /// <summary>
        /// for qua thêm các ký tự đầu vào stack, sau đó kiểm tra nó ký tự thứ 2 là ký tự đóng
        /// và stack != rỗng và dùng Peek để láy ra ký tự đầu trong stack == ký tự mở thì remove đi ký tự đó => hợp lệ
        /// ngược lại không thỏa dk thì sẽ ko phải là cặp đấu open/close
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool isValidString(string str)
        {
            Stack<char> leftSymbols = new Stack<char>();
            foreach (char c in str.ToCharArray())
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    leftSymbols.Push(c);
                } else if (c == ')' && leftSymbols.Any() && leftSymbols.Peek() == '(')
                {
                    leftSymbols.Pop();
                } else if (c == '}' && leftSymbols.Any() && leftSymbols.Peek() == '{')
                {
                    leftSymbols.Pop();
                } else if (c == ']' && leftSymbols.Any() && leftSymbols.Peek() == '[')
                {
                    leftSymbols.Pop();
                }
            }
            return !leftSymbols.Any();
        }
    }
}
