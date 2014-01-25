namespace proto {
	public class m_marry_save_point_tos : Message
	{
		public object[] points;
		public m_marry_save_point_tos() {
		}
		public override string getMethodName() {
			return "marry_save_point";
		}
		public override string getClassName() {
			return "m_marry_save_point_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"points", "array", "int"}};
		}
	}
}
