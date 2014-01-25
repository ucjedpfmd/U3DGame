namespace proto {
	public class m_flowers_give_tos : Message
	{
		public double rece_role_id = 0;
		public int goods_id = 0;
		public int flowers_type = 0;
		public bool is_anonymous = true;
		public int flower_time = 0;
		public m_flowers_give_tos() {
		}
		public override string getMethodName() {
			return "flowers_give";
		}
		public override string getClassName() {
			return "m_flowers_give_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rece_role_id", "double", "null"},new string[] {"goods_id", "int", "null"},new string[] {"flowers_type", "int", "null"},new string[] {"is_anonymous", "bool", "null"},new string[] {"flower_time", "int", "null"}};
		}
	}
}
