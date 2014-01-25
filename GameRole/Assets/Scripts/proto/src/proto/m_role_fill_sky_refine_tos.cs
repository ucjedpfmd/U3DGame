namespace proto {
	public class m_role_fill_sky_refine_tos : Message
	{
		public int op_type = 0;
		public m_role_fill_sky_refine_tos() {
		}
		public override string getMethodName() {
			return "role_fill_sky_refine";
		}
		public override string getClassName() {
			return "m_role_fill_sky_refine_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
