namespace proto {
	public class p_tower_barrier : Message
	{
		public int barrier = 0;
		public bool is_open = true;
		public int times = 0;
		public p_tower_barrier() {
		}
		public override string getClassName() {
			return "p_tower_barrier";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"barrier", "int", "null"},new string[] {"is_open", "bool", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
