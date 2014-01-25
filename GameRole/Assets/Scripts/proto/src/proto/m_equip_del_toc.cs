namespace proto {
	public class m_equip_del_toc : Message
	{
		public object[] load_poses;
		public p_goods new_equip = null;
		public p_skin new_skin = null;
		public m_equip_del_toc() {
		}
		public override string getMethodName() {
			return "equip_del";
		}
		public override string getClassName() {
			return "m_equip_del_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"load_poses", "array", "int"},new string[] {"new_equip", "p_goods", "null"},new string[] {"new_skin", "p_skin", "null"}};
		}
	}
}
