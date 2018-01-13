using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Arm
{
    public long EnergyConsumption { get; set; }
    public decimal ArmReachDistance { get; set; }
    public decimal Fingers { get; set; }

    string result = string.Empty;
    public override string ToString()
    {
        result += "#Arm:\r\n";
        result += "###Energy consumption: " + EnergyConsumption + "\r\n";
        result += string.Format($"###Reach: {ArmReachDistance}\r\n");
        result += string.Format($"###Fingers: {Fingers}\r\n");

        return result;
    }
}

public class Leg
{
    public long EnergyConsumption { get; set; }
    public decimal Strength { get; set; }
    public decimal Speed { get; set; }

    public override string ToString()
    {
        string result = string.Empty;

        result += "#Leg:\r\n";
        result += "###Energy consumption: " + EnergyConsumption + "\r\n";
        result += string.Format($"###Strength: {Strength}\r\n");
        result += string.Format($"###Speed: {Speed}\r\n");

        return result;
    }
}

public class Torso
{
    public long EnergyConsumption { get; set; }
    public decimal ProcessorSizeInCentimeters { get; set; }
    public string Material { get; set; }

    string result = string.Empty;

    public override string ToString()
    {
        result += "#Torso:\r\n";
        result += "###Energy consumption: " + EnergyConsumption + "\r\n";
        result += string.Format($"###Processor size: {ProcessorSizeInCentimeters:F1}\r\n");
        result += string.Format($"###Corpus material: {Material}\r\n");

        return result;
    }
}

public class Head
{
    public long EnergyConsumption { get; set; }
    public decimal Iq { get; set; }
    public string Material { get; set; }

    string result = string.Empty;
    public override string ToString()
    {
        result += "#Head:\r\n";
        result += "###Energy consumption: " + EnergyConsumption + "\r\n";
        result += string.Format($"###IQ: {Iq}\r\n");
        result += string.Format($"###Skin material: {Material}\r\n");

        return result;
    }
}

public class JarvisBuild
{
    public long EnergyConsumption { get; set; }
    public Head Head { get; set; }
    public Torso Torso { get; set; }
    public List<Arm> Arms { get; set; }
    public List<Leg> Legs { get; set; }

    public void AddHead(Head headInput)
    {

        if (Head == null)
        {
            Head = headInput;
        }

        if (headInput.EnergyConsumption < this.Head.EnergyConsumption)
        {
            this.Head = headInput;
        }
    }

    public void AddTorso(Torso torsoInput)
    {
        if (Torso == null)
        {
            Torso = torsoInput;
        }
        if (torsoInput.EnergyConsumption < this.Torso.EnergyConsumption)
        {
            this.Torso = torsoInput;
        }
    }

    public void AddArm(Arm arm)
    {
        if (Arms == null)
        {
            Arms = new List<Arm>();
        }
        if (Arms.Count < 2)
        {
            Arms.Add(arm);
        }
        else
        {
            for (int i = 0; i < this.Arms.Count; i++)
            {
                if (Arms[i].EnergyConsumption > arm.EnergyConsumption)
                {
                    Arms.RemoveAt(i);
                    Arms.Add(arm);
                }
            }
        }
    }

    public void AddLegs(Leg leg)
    {
        if (Legs == null)
        {
            Legs = new List<Leg>();
        }

        if (Legs.Count < 2)
        {
            Legs.Add(leg);
        }
        else
        {
            for (int i = 0; i < this.Legs.Count; i++)
            {
                if (Legs[i].EnergyConsumption > leg.EnergyConsumption)
                {
                    Legs.RemoveAt(i);
                    Legs.Add(leg);
                }
            }
        }
    }

    public override string ToString()
    {
        if (Head == null || Torso == null || Arms.Count < 2 || Legs.Count < 2)
        {
            return "We need more parts!";
        }

        long totalEnergy = 0L;
        totalEnergy += Head.EnergyConsumption;
        totalEnergy += Torso.EnergyConsumption;
        totalEnergy += Arms.Select(a => long.Parse(a.EnergyConsumption.ToString())).Sum();
        totalEnergy += Legs.Select(a => long.Parse(a.EnergyConsumption.ToString())).Sum();

        if (totalEnergy > EnergyConsumption)
        {
            return "We need more power!";
        }

        StringBuilder sb = new StringBuilder();

        sb.Append("Jarvis:\r\n");
        sb.Append(Head.ToString());
        sb.Append(Torso.ToString());

        foreach (var arm in Arms.OrderBy(a => a.EnergyConsumption))
        {
            sb.Append(arm.ToString());
        }

        foreach (var leg in Legs.OrderBy(a => a.EnergyConsumption))
        {
            sb.Append(leg.ToString());
        }

        return sb.ToString();
    }
}

public class Jarvis
{
    public static void Main()
    {
        var jarvisEnergy = long.Parse(Console.ReadLine());

        JarvisBuild jarvis = new JarvisBuild();
        jarvis.EnergyConsumption = jarvisEnergy;

        while (true)
        {
            string[] tokens = Console.ReadLine().Split(' ');

            if (tokens[0] == "Assemble!")
            {
                break;
            }
            switch (tokens[0])
            {
                case "Head":
                    Head head = new Head()
                    {
                        EnergyConsumption = long.Parse(tokens[1]),
                        Iq = int.Parse(tokens[2]),
                        Material = tokens[3]
                    };
                    jarvis.AddHead(head);
                    break;

                case "Torso":
                    Torso torso = new Torso()
                    {
                        EnergyConsumption = long.Parse(tokens[1]),
                        ProcessorSizeInCentimeters = decimal.Parse(tokens[2]),
                        Material = tokens[3]
                    };
                    jarvis.AddTorso(torso);
                    break;
                case "Leg":
                    Leg leg = new Leg()
                    {
                        EnergyConsumption = long.Parse(tokens[1]),
                        Strength = int.Parse(tokens[2]),
                        Speed = int.Parse(tokens[3])
                    };
                    jarvis.AddLegs(leg);
                    break;

                case "Arm":
                    Arm arm = new Arm()
                    {
                        EnergyConsumption = long.Parse(tokens[1]),
                        ArmReachDistance = int.Parse(tokens[2]),
                        Fingers = int.Parse(tokens[3])
                    };
                    jarvis.AddArm(arm);
                    break;
            }
        }

        Console.WriteLine(jarvis.ToString());
    }
}