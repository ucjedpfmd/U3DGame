namespace proto {
	public class p_mount_skin : Message
	{
		public int skin_id = 0;
		public int type_id = 0;
		public int start_time = 0;
		public int end_time = 0;
		public p_mount_skin() {
		}
		public override string getClassName() {
			return "p_mount_skin";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skin_id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"start_time", "int", "null"},new string[] {"end_time", "int", "null"}};
		}
	}
}
