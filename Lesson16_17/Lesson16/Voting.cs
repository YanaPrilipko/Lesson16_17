class Voting
{
    private Dictionary<string, int> topics = new Dictionary<string, int>();

    public void CreateTopic(string topicName)
    {
        topics[topicName] = 0;
    }

    public string ListTopics()
    {
        string str ="";
        foreach (var topic in topics.Keys)
        {
            str += topic+ "\n";
        }
        return str;
    }

    public int Vote(string selectedTopic)
    {
        if (topics.ContainsKey(selectedTopic))//метод для проверки наличия ключа перед вызовом Add метода .
        {
             return topics[selectedTopic]++;
        }
        return int.Parse("There is no such topic");
    }

    public string Results()
    {
        string str = "";
        int voices = 0;
        foreach (var topic in topics)
        {
            str = topic.Key;
            voices = topic.Value;
        }
        return str + " " + voices; 
    }
}


