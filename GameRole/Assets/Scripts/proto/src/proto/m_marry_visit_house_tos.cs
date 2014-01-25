namespace proto {
	public class m_marry_visit_house_tos : Message
	{
		public int op_type = 0;
		public double role_id = 0;
		public m_marry_visit_house_tos() {
		}
		public override string getMethodName() {
			return "marry_visit_house";
		}
		public override string getClassName() {
			return "m_marry_visit_house_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
