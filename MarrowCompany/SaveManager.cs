namespace MarrowCompany;

internal static class SaveManager
{
    public static int Money { get; private set; }
    public static int Flashlights { get; private set; }
    public static int Shovels { get; private set; }
    public static int Quota { get; private set; }
    public static int Day { get; private set; }
    
    private static JsonStructure _data;
    
    public static void LoadSave()
    {
        var content = File.ReadAllText(UserData.SaveFile);
        _data = JsonConvert.DeserializeObject<JsonStructure>(content);
        Money = _data.Items.Money;
        Flashlights = _data.Items.Flashlights;
        Shovels = _data.Items.Shovels;
        Quota = _data.GameData.Quota;
        Day = _data.GameData.Day;
    }

    public static void IncrementField(JsonField jsonField, int amount = 1)
    {
        switch (jsonField)
        {
            case JsonField.Money:
                _data.Items.Money += amount;
                var updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Flashlights:
                _data.Items.Flashlights += amount;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Shovels:
                _data.Items.Shovels += amount;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Quota:
                _data.GameData.Quota += amount;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Day:
                _data.GameData.Day += amount;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            default:
                ModConsole.Error("Invalid field type!");
                break;
        }
        LoadSave();
    }

    public static void DecrementField(JsonField jsonField, int amount = 1)
    {
        switch (jsonField)
        {
            case JsonField.Money:
                _data.Items.Money -= amount;
                var updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Flashlights:
                _data.Items.Flashlights -= amount;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Shovels:
                _data.Items.Shovels -= amount;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Quota:
                _data.GameData.Quota -= amount;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Day:
                _data.GameData.Day -= amount;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            default:
                ModConsole.Error("Invalid field type!");
                break;
        }
        LoadSave();
    }

    public static void ResetField(JsonField jsonField)
    {
        switch (jsonField)
        {
            case JsonField.Money:
                _data.Items.Money = 0;
                var updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Flashlights:
                _data.Items.Flashlights = 0;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Shovels:
                _data.Items.Shovels = 0;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Quota:
                _data.GameData.Quota = 0;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            case JsonField.Day:
                _data.GameData.Day = 0;
                updated = JsonConvert.SerializeObject(_data);
                File.WriteAllText(UserData.SaveFile, updated);
                break;
            default:
                ModConsole.Error("Invalid field type!");
                break;
        }
        LoadSave();
    }

    public static void ResetAll()
    {
        _data.Items.Money = 0;
        _data.Items.Flashlights = 0;
        _data.Items.Shovels = 0;
        _data.GameData.Quota = 0;
        _data.GameData.Day = 0;
        var updated = JsonConvert.SerializeObject(_data);
        File.WriteAllText(UserData.SaveFile, updated);
        LoadSave();
    }
}

#region Json Structure and Enum

public class JsonStructure
{
    [JsonProperty("items")]
    public Items Items { get; set; }
    [JsonProperty("gameData")]
    public GameData GameData { get; set; }
}

public class Items
{
    [JsonProperty("money")]
    public int Money { get; set; }
    [JsonProperty("flashlights")]
    public int Flashlights { get; set; }
    [JsonProperty("shovels")]
    public int Shovels { get; set; }
}

public class GameData
{
    [JsonProperty("quota")]
    public int Quota { get; set; }
    [JsonProperty("day")]
    public int Day { get; set; }
}

public enum JsonField
{
    Money,
    Flashlights,
    Shovels,
    Quota,
    Day
}

#endregion