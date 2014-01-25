namespace proto {
	public class p_role_family_battle_result : Message
	{
		public double role_id = 0;
		public int treasure = 0;
		public int station = 0;
		public int contribution = 0;
		public int score = 0;
		public p_role_family_battle_result() {
		}
		public override string getClassName() {
			return "p_role_family_battle_result";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"treasure", "int", "null"},new string[] {"station", "int", "null"},new string[] {"contribution", "int", "null"},new string[] {"score", "int", "null"}};
		}
	}
}
