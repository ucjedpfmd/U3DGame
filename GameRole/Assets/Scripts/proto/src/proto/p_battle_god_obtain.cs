namespace proto {
	public class p_battle_god_obtain : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int times = 0;
		public p_battle_god_obtain() {
		}
		public override string getClassName() {
			return "p_battle_god_obtain";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
