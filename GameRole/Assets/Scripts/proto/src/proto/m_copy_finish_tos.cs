namespace proto {
	public class m_copy_finish_tos : Message
	{
		public int map_id = 0;
		public m_copy_finish_tos() {
		}
		public override string getMethodName() {
			return "copy_finish";
		}
		public override string getClassName() {
			return "m_copy_finish_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"}};
		}
	}
}
