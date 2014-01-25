namespace proto {
	public class p_cut_soul : Message
	{
		public bool finish = false;
		public int cur_num = 0;
		public int total_num = 0;
		public p_cut_soul() {
		}
		public override string getClassName() {
			return "p_cut_soul";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"finish", "bool", "null"},new string[] {"cur_num", "int", "null"},new string[] {"total_num", "int", "null"}};
		}
	}
}
