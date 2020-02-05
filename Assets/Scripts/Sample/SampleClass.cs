using UnityEngine;
using MessagePack;
namespace Assets.Scripts.Sample
{
    public class SampleClass : MonoBehaviour
    {
        void Start()
        {
            // シリアライズ側(サーバーとか)
            var usr1 = new UsrData
            {
                Id = 123456,
                Name = "Moosan",
                Age = 21
            };
            var bin = MessagePackSerializer.Serialize(usr1);

            // デシリアライズ側(クライアントとか)
            UsrData usr = MessagePackSerializer.Deserialize<UsrData>(bin);

            // Jsonとの互換
            string json = MessagePackSerializer.ToJson(bin);
            Debug.Log(json);// [123456,"Moosan",21]
        }
    }

    [MessagePackObject]
    public class UsrData
    {
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public int Age { get; set; }
    }
}