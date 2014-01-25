namespace proto {
	public class m_marry_house_layout_tos : Message
	{
		public int op_type = 0;
		public bool is_furniture = true;
		public int id = 0;
		public int pos = 0;
		public int effect = 0;
		public m_marry_house_layout_tos() {
		}
		public override string getMethodName() {
			return "marry_house_layout";
		}
		public override string getClassName() {
			return "m_marry_house_layout_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"is_furniture", "bool", "null"},new string[] {"id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"effect", "int", "null"}};
		}
	}
}
