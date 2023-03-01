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

#endif /* __REGRESS_MISC_H__ */
