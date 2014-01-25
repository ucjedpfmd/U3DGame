namespace proto {
	public class p_pet_embattle_attack_effect : Message
	{
		public int pos = 0;
		public bool is_double = false;
		public int remain_hp = 0;
		public int change_hp = 0;
		public int remain_rage = 0;
		public int change_rage = 0;
		public p_pet_embattle_attack_effect() {
		}
		public override string getClassName() {
			return "p_pet_embattle_attack_effect";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pos", "int", "null"},new string[] {"is_double", "bool", "null"},new string[] {"remain_hp", "int", "null"},new string[] {"change_hp", "int", "null"},new string[] {"remain_rage", "int", "null"},new string[] {"change_rage", "int", "null"}};
		}
	}
}
