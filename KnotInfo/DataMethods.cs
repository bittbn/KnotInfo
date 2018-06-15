using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Drawing;

namespace KnotInfo
{
    struct StructGuide
    {
        public Binary guideBinary;
        public string guideComment;

        public StructGuide(string guideComment, Binary guideBinary)
        {
            this.guideComment = guideComment;
            this.guideBinary = guideBinary;
        }
    }

    struct StructGuideKnot
    {
        public Binary guideBinary;
        public Binary knotBinary;
        public string typeName;
        public string knotName;
        public string knotComment;
        public string guideComment;

        public StructGuideKnot(string knotName, string knotComment, Binary knotBinary, string guideComment, Binary guideBinary, string typeName)
        {
            this.knotName = knotName;
            this.knotComment = knotComment;
            this.knotBinary = knotBinary;
            this.guideComment = guideComment;
            this.guideBinary = guideBinary;
            this.typeName = typeName;
        }
    }

    class DataMethods
    {
        private static DataClassesDataContext db = new DataClassesDataContext();

        public static void DisposeDB()
        {
            db.Dispose();
        }

        public static StructGuide GetGuide(int knotId)
        {
            return db.Knots
            .Join(db.Guides, k => k.guide_id, g => g.id, (k, g) => new { k, g })
            .Where(w => w.k.id.Equals(knotId))
            .Select(s => new StructGuide(s.g.comment, s.g.image))
            .First();
        }

        public static IQueryable GetKnots()
        {
            return db.Knots
                .Join(db.Types, k => k.type_id, t => t.id, (k, t) => new
                {
                    id = k.id,
                    Изображение = k.image,
                    Узел = k.name,
                    Комментарий = k.comment,
                    Тип = t.name
                });
        }

        public static StructGuideKnot GetKnot(int knotId)
        {
            return db.Knots
                    .Join(db.Types, k => k.type_id, t => t.id, (k, t) => new { k, t })
                    .Join(db.Guides, kk => kk.k.guide_id, g => g.id, (kk, g) => new { kk, g })
                    .Where(w => w.kk.k.id.Equals(knotId))
                    .Select(s => new StructGuideKnot(s.kk.k.name, s.kk.k.comment, s.kk.k.image, s.g.comment, s.g.image, s.kk.t.name))
                    .First();
        }

        public static Table<Types> GetTypes()
        {
            return db.Types;
        }

        public static void DeleteKnot(int knotId)
        {
            Knots knot = db.Knots.Where(k => k.id.Equals(knotId)).Single();
            Guides guide = db.Guides.Where(g => g.id.Equals(knot.guide_id)).Single();

            db.Knots.DeleteOnSubmit(knot);
            db.Guides.DeleteOnSubmit(guide);
            db.SubmitChanges();

            MessageBox.Show("Узел <" + knot.name + "> успешно удален", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void InsertKnot(string knotName, string knotComment, Binary knotBinary, string guideComment, Binary guideBinary, int typeId)
        {
            bool exist = db.Knots.Where(k => k.name.Equals(knotName)).Any();

            if (exist != true)
            {
                Guides newGuide = new Guides
                {
                    comment = guideComment,
                    image = guideBinary
                };

                db.Guides.InsertOnSubmit(newGuide);
                db.SubmitChanges();

                Guides guide = db.Guides.ToList().Last();

                Knots newKnot = new Knots
                {
                    name = knotName,
                    comment = knotComment,
                    image = knotBinary,
                    type_id = typeId,
                    guide_id = guide.id
                };

                db.Knots.InsertOnSubmit(newKnot);
                db.SubmitChanges();

                MessageBox.Show("Новый узел <" + knotName+ "> успешно добавлен.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Узел с названием <" + knotName + "> уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateKnot(int knotId, string knotName, string knotComment, Binary knotBinary, string guideComment, Binary guideBinary, int typeId)
        {
            Knots knot = db.Knots.Where(k => k.id.Equals(knotId)).Single();
            Guides guide = db.Guides.Where(g => g.id.Equals(knot.guide_id)).Single();

            knot.name = knotName;
            knot.comment = knotComment;
            knot.image = knotBinary;
            knot.type_id = typeId;
            guide.comment = guideComment;
            guide.image = guideBinary;
            db.SubmitChanges();

            MessageBox.Show("Данные об узле <" + knotName+ ">, успешно изменены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static IQueryable SearchKnots(string str)
        {
            return db.Knots
                .Where(k => k.name.StartsWith(str))
                .Join(db.Types, k => k.type_id, t => t.id, (k, t) => new
                {
                    id = k.id,
                    Изображение = k.image,
                    Узел = k.name,
                    Комментарий = k.comment,
                    Тип = t.name
                });
        }
    }
}
