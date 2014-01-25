namespace proto {
	public class m_walk_pet_info_toc : Message
	{
		public int walk_time = 0;
		public int fellowship_time = 0;
		public object[] pets;
		public object[] actions;
		public m_walk_pet_info_toc() {
		}
		public override string getMethodName() {
			return "walk_pet_info";
		}
		public override string getClassName() {
			return "m_walk_pet_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"walk_time", "int", "null"},new string[] {"fellowship_time", "int", "null"},new string[] {"pets", "array", "p_walk_pet"},new string[] {"actions", "array", "p_key_value"}};
		}
	}
}
