#region Opdracht 1


static void Opg1FilterList(List<int> lijst)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();

    foreach (int nummer in lijst)
    {
        if (!dict.ContainsKey(nummer))
        {
            dict.Add(nummer, 1); // toevoegen
        }
        else
        {
            dict[nummer] = dict[nummer] + 1; // update
        }
    }

    foreach (int nummer in lijst)
    {
        if (dict[nummer] > 1)
        {
            Console.Write(nummer + "\t");
        }
        else
        {
            dict.Remove(nummer);
        }
    }
}

List<int> list = new List<int>() { 1, 3, 5, 7, 3, 8, 9, 5 };
Opg1FilterList(list);


#endregion
