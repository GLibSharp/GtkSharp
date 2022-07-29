/* misc contains API that is not part of gobject-introspection's regress files
 * that are synced from the upstream repository
 */
#ifndef __REGRESS_MISC_H__
#define __REGRESS_MISC_H__

#include "gitestmacros.h"
#include "utility.h"

_GI_TEST_EXTERN
void regress_misc_array_parameter_with_length_parameter_shared (gint length, guint8* array1, guint8* array2);

#endif /* __REGRESS_MISC_H__ */
