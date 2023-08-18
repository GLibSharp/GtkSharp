/* misc contains API that is not part of gobject-introspection's regress files
 * that are synced from the upstream repository
 */
#ifndef __REGRESS_MISC_H__
#define __REGRESS_MISC_H__

#include "gitestmacros.h"
#include "foo.h"

_GI_TEST_EXTERN
void regress_misc_array_parameter_with_length_parameter_shared (gint length, RegressFooObject* array1, guint8* array2);

_GI_TEST_EXTERN
void regress_misc_array_marshalling_with_uint_length (const RegressFooObject* formats, guint len, int layout);

#define REGRESS_MISC_TYPE_OBJECT         (regress_misc_object_get_type ())
#define REGRESS_MISC_OBJECT (object)     (G_TYPE_CHECK_INSTANCE_CAST ((object), REGRESS_MISC_TYPE_OBJECT, RegressMiscObject))
#define REGRESS_MISC_IS_OBJECT (object)  (G_TYPE_CHECK_INSTANCE_TYPE ((object), REGRESS_MIC_TYPE_OBJECT))

typedef struct _RegressMiscObject          RegressMiscObject;
typedef struct _RegressMiscObjectClass     RegressMiscObjectClass;

struct _RegressMiscObject
{
  GObject parent_instance;
};


/**
 * RegressMiscObjectClass:
 * @parent_class:  Object parent class
 *
 * The #GstBufferPool class.
 */
struct _RegressMiscObjectClass
{
  GObjectClass parent_class;

  /*< public >*/
  /**
   * RegressMiscObjectClass::get_options:
   * @miscobj: the #MiscObject
   *
   * Get a list of options supported by this pool
   *
   * Returns: (array zero-terminated=1) (transfer none): a %NULL terminated array
   *          of strings.
   */
  const gchar ** (*get_options)    (RegressMiscObject *miscobj);
};

_GI_TEST_EXTERN
GType                 regress_misc_object_get_type       (void) G_GNUC_CONST;

_GI_TEST_EXTERN
const gchar **   regress_misc_object_get_options     (RegressMiscObject *miscobj);

#endif /* __REGRESS_MISC_H__ */
