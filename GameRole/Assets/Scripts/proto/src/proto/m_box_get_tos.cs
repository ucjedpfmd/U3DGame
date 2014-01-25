namespace proto {
	public class m_box_get_tos : Message
	{
		public int id = 0;
		public m_box_get_tos() {
		}
		public override string getMethodName() {
			return "box_get";
		}
		public override string getClassName() {
			return "m_box_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
