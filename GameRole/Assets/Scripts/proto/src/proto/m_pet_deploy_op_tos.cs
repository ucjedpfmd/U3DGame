namespace proto {
	public class m_pet_deploy_op_tos : Message
	{
		public int op_type = 0;
		public int index = 0;
		public double pet_id = 0;
		public m_pet_deploy_op_tos() {
		}
		public override string getMethodName() {
			return "pet_deploy_op";
		}
		public override string getClassName() {
			return "m_pet_deploy_op_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"index", "int", "null"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
