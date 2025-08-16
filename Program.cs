class Program
{
    public static void Main(string[] args)
    {
        string[] students = new[] { "Chistian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Xachariah", "Mallory", "Zoe", "Emily" };
        Console.WriteLine("Nhap ten cua sinh vien: ");
        string input_name = Console.ReadLine();
        bool isExist = false;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Equals(input_name))
            {
                Console.WriteLine("Vi tri cua hoc sinh trong danh sach " + input_name + " la: " + (i + 1));
                isExist = true;
                break;
            }
        }
        if (!isExist)
        {
        Console.WriteLine("Khong tim thay" + input_name + "trong danh sach"); 
        }
    }
}