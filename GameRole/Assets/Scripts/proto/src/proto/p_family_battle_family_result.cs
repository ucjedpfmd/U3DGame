namespace proto {
	public class p_family_battle_family_result : Message
	{
		public double family_id = 0;
		public string family_name = null;
		public int card = 0;
		public int score = 0;
		public int rank = 0;
		public p_family_battle_family_result() {
		}
		public override string getClassName() {
			return "p_family_battle_family_result";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"card", "int", "null"},new string[] {"score", "int", "null"},new string[] {"rank", "int", "null"}};
		}
	}
}
