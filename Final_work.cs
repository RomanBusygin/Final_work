Console.Write("Введите текст через запятую: ");
string text = Console.ReadLine()!;
int limit = 3;
int count = 1;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == ',') count++;
}

string[] textArray = new string[count];
string[] newTextArray = new string[count];
count = 0;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] != ',') textArray[count] += text[i];
    else count++;
}
count = 0;

for (int i = 0; i < textArray.Length; i++)
{
    if (textArray[i].Length <= limit)
    {
        newTextArray[count] = textArray[i];
        count++;
    }
}

PrintArray(newTextArray);


void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}