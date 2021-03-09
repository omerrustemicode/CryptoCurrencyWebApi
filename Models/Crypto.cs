using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace CryptoWebApi.Models
{
    [DataContract]
    [Serializable]
    public class Crypto
    {
     
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    [DataContract]
    [Serializable]
    public class USD
    {
        [DataMember(Name = "TYPE")]
        [JsonProperty("TYPE")]
        public string TYPE { get; set; }
        public string MARKET { get; set; }
        public string FROMSYMBOL { get; set; }
        public string TOSYMBOL { get; set; }
        public string FLAGS { get; set; }
        [DataMember(Name = "PRICE")]
        [JsonProperty("PRICE")]
        public string PRICE { get; set; }
        public int LASTUPDATE { get; set; }
        public double MEDIAN { get; set; }
        public double LASTVOLUME { get; set; }
        public double LASTVOLUMETO { get; set; }
        public string LASTTRADEID { get; set; }
        public double VOLUMEDAY { get; set; }
        public double VOLUMEDAYTO { get; set; }
        public double VOLUME24HOUR { get; set; }
        public double VOLUME24HOURTO { get; set; }
        public double OPENDAY { get; set; }
        public double HIGHDAY { get; set; }
        public double LOWDAY { get; set; }
        public double OPEN24HOUR { get; set; }
        public double HIGH24HOUR { get; set; }
        public double LOW24HOUR { get; set; }
        public string LASTMARKET { get; set; }
        public double VOLUMEHOUR { get; set; }
        public double VOLUMEHOURTO { get; set; }
        public double OPENHOUR { get; set; }
        public double HIGHHOUR { get; set; }
        public double LOWHOUR { get; set; }
        public double TOPTIERVOLUME24HOUR { get; set; }
        public double TOPTIERVOLUME24HOURTO { get; set; }
        [DataMember(Name = "CHANGE24HOUR")]
        [JsonProperty("CHANGE24HOUR")]
        public string CHANGE24HOUR { get; set; }
        public double CHANGEPCT24HOUR { get; set; }
        public double CHANGEDAY { get; set; }
        public double CHANGEPCTDAY { get; set; }
        [DataMember(Name = "CHANGEHOUR")]
        [JsonProperty("CHANGEHOUR")]
        public string CHANGEHOUR { get; set; }
        public double CHANGEPCTHOUR { get; set; }
        public string CONVERSIONTYPE { get; set; }
        public string CONVERSIONSYMBOL { get; set; }
        [DataMember(Name = "SUPPLY")]
        [JsonProperty("SUPPLY")]
        public string SUPPLY { get; set; }
        [DataMember(Name = "MKTCAP")]
        [JsonProperty("MKTCAP")]
        public string MKTCAP { get; set; }
        public int MKTCAPPENALTY { get; set; }
        public double TOTALVOLUME24H { get; set; }
        public double TOTALVOLUME24HTO { get; set; }
        public double TOTALTOPTIERVOLUME24H { get; set; }
        public double TOTALTOPTIERVOLUME24HTO { get; set; }
        [DataMember(Name = "IMAGEURL")]
        [JsonProperty("IMAGEURL")]
        public string IMAGEURL { get; set; }
    }
    [DataContract]
    [Serializable]
    public class EUR
    {
        public string TYPE { get; set; }
        public string MARKET { get; set; }
        public string FROMSYMBOL { get; set; }
        public string TOSYMBOL { get; set; }
        public string FLAGS { get; set; }
        [DataMember(Name = "PRICE")]
        [JsonProperty("PRICE")]
        public double PRICE { get; set; }
        public int LASTUPDATE { get; set; }
        public int MEDIAN { get; set; }
        public double LASTVOLUME { get; set; }
        public double LASTVOLUMETO { get; set; }
        public string LASTTRADEID { get; set; }
        public double VOLUMEDAY { get; set; }
        public double VOLUMEDAYTO { get; set; }
        public double VOLUME24HOUR { get; set; }
        public double VOLUME24HOURTO { get; set; }
        public double OPENDAY { get; set; }
        public double HIGHDAY { get; set; }
        public double LOWDAY { get; set; }
        public double OPEN24HOUR { get; set; }
        public double HIGH24HOUR { get; set; }
        public double LOW24HOUR { get; set; }
        public string LASTMARKET { get; set; }
        public double VOLUMEHOUR { get; set; }
        public double VOLUMEHOURTO { get; set; }
        public double OPENHOUR { get; set; }
        public double HIGHHOUR { get; set; }
        public double LOWHOUR { get; set; }
        public double TOPTIERVOLUME24HOUR { get; set; }
        public double TOPTIERVOLUME24HOURTO { get; set; }
        public double CHANGE24HOUR { get; set; }
        public double CHANGEPCT24HOUR { get; set; }
        public double CHANGEDAY { get; set; }
        public double CHANGEPCTDAY { get; set; }
        public double CHANGEHOUR { get; set; }
        public double CHANGEPCTHOUR { get; set; }
        public string CONVERSIONTYPE { get; set; }
        public string CONVERSIONSYMBOL { get; set; }
        public int SUPPLY { get; set; }
        [DataMember(Name = "MKTCAP")]
        [JsonProperty("MKTCAP")]
        public double MKTCAP { get; set; }
        public int MKTCAPPENALTY { get; set; }
        public double TOTALVOLUME24H { get; set; }
        public double TOTALVOLUME24HTO { get; set; }
        public double TOTALTOPTIERVOLUME24H { get; set; }
        public double TOTALTOPTIERVOLUME24HTO { get; set; }
        public string IMAGEURL { get; set; }
    }
    [DataContract]
    [Serializable]
    public class BTC
    {
        [DataMember(Name = "USD")]
        [JsonProperty("USD")]
        public USD USD { get; set; }
        public EUR EUR { get; set; }
    }
    [DataContract]
    [Serializable]
    public class ETH
    {
        [DataMember(Name = "USD")]
        [JsonProperty("USD")]
        public USD USD { get; set; }
        public EUR EUR { get; set; }
    }
    [DataContract]
    [Serializable]
    public class RAW
    {
        [DataMember(Name = "BTC")]
        [JsonProperty("BTC")]
        public BTC BTC { get; set; }
        [DataMember(Name = "ETH")]
        [JsonProperty("ETH")]
        public ETH ETH { get; set; }
    }
    [DataContract]
    [Serializable]
    public class DISPLAY
    {
        [DataMember(Name = "BTC")]
        [JsonProperty("BTC")]
        public BTC BTC { get; set; }
        [DataMember(Name = "ETH")]
        [JsonProperty("ETH")]
        public ETH ETH { get; set; }
    }
    [DataContract]
    [Serializable]
    public class Root
    {
        [DataMember(Name = "RAW")]
        [JsonProperty("RAW")]
        public RAW RAW { get; set; }
        [DataMember(Name = "DISPLAY")]
        [JsonProperty("DISPLAY")]
        public DISPLAY DISPLAY { get; set; }
    }






}
