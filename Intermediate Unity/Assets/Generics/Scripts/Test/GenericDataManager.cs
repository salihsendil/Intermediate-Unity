using UnityEngine;

public class GenericDataManager : MonoBehaviour
{

    void Start()
    {
        GenericDataRepository<string> _stringRepo = new GenericDataRepository<string>();
        _stringRepo.SaveData("String Variable");
        _stringRepo.GetData();
        _stringRepo.ClearData();

        GenericDataRepository<int> _intRepo = new GenericDataRepository<int>();
        _intRepo.SaveData(48);
        _intRepo.GetData();
        _intRepo.ClearData();

        GenericDataRepository<float> _floatRepo = new GenericDataRepository<float>();
        _floatRepo.SaveData(8.4f);
        _floatRepo.GetData();
        _floatRepo.ClearData();

    }
}
