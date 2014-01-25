namespace proto {
	public class m_pet_fuse_tos : Message
	{
		public double pet_id1 = 0;
		public double pet_id2 = 0;
		public int new_skin_id = 0;
		public int new_att_type = 0;
		public m_pet_fuse_tos() {
		}
		public override string getMethodName() {
			return "pet_fuse";
		}
		public override string getClassName() {
			return "m_pet_fuse_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id1", "double", "null"},new string[] {"pet_id2", "double", "null"},new string[] {"new_skin_id", "int", "null"},new string[] {"new_att_type", "int", "null"}};
		}
	}
}
